﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Vulild.Core.Algorithms
{
    /// <summary>
    /// 动态生产有规律的ID Snowflake算法是Twitter的工程师为实现递增而不重复的ID实现的
    /// C# 实现 Snowflake算法 
    /// </summary>
    public class Snowflake
    {
        private long machineId;//机器ID
        private long datacenterId = 0L;//数据ID
        private long sequence = 0L;//计数从零开始

        //private long twepoch = 687888001020L; //唯一时间随机量

        public long MachineIdBits = 5L; //机器码字节数
        public long DataCenterIdBits = 0L;//数据中心字节数
        private long maxMachineId => -1L ^ (-1L << (int)MachineIdBits); //最大机器ID
        private long maxDatacenterId => -1L ^ (-1L << (int)DataCenterIdBits);//最大数据ID

        public long SequenceBits = 6L; //计数器字节数，12个字节用来保存计数码        

        public int TimeStampBits = 41;

        private long maxTimeStamp => -1L ^ (-1L << TimeStampBits);//最大时间

        private long machineIdShift => SequenceBits; //机器码数据左移位数，就是后面计数器占用的位数
        private long datacenterIdShift => SequenceBits + MachineIdBits;
        private long timestampLeftShift => SequenceBits + MachineIdBits + DataCenterIdBits; //时间戳左移动位数就是机器码+计数器总字节数+数据字节数
        private long sequenceMask => -1L ^ (-1L << (int)SequenceBits); //一微秒内可以产生计数，如果达到该值则等到下一微妙在进行生成
        private long lastTimestamp = -1L;//最后时间戳

        private long lastId = -1L;

        private object syncRoot = new object();//加锁对象
        static Snowflake snowflake;

        public static Snowflake Instance()
        {
            if (snowflake == null)
                snowflake = new Snowflake();
            return snowflake;
        }

        public Snowflake()
        {
            Snowflakes(0L, -1);
        }

        public Snowflake(long machineId)
        {
            Snowflakes(machineId, -1);
        }

        public Snowflake(long machineId, long datacenterId)
        {
            Snowflakes(machineId, datacenterId);
        }

        private void Snowflakes(long machineId, long datacenterId)
        {
            if (machineId >= 0)
            {
                if (machineId > maxMachineId)
                {
                    throw new Exception("机器码ID非法");
                }
                this.machineId = machineId;
            }
            if (datacenterId >= 0)
            {
                if (datacenterId > maxDatacenterId)
                {
                    throw new Exception("数据中心ID非法");
                }
                this.datacenterId = datacenterId;
            }
        }

        /// <summary>
        /// 生成当前时间戳
        /// </summary>
        /// <returns>毫秒</returns>
        private long GetTimestamp()
        {
            //让他2000年开始
            return ((long)(DateTime.UtcNow - new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds) & maxTimeStamp;
        }

        /// <summary>
        /// 获取下一微秒时间戳
        /// </summary>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        private long GetNextTimestamp(long lastTimestamp)
        {
            long timestamp = GetTimestamp();
            while (timestamp <= lastTimestamp)
            {
                timestamp = lastTimestamp++;
            }
            return timestamp;
        }

        /// <summary>
        /// 获取长整形的ID
        /// </summary>
        /// <returns></returns>
        public long NewId()
        {
            lock (syncRoot)
            {
                long timestamp = GetTimestamp();
                if (this.lastTimestamp == timestamp)
                {
                    //同一微秒中生成ID
                    sequence = (sequence + 1) & sequenceMask; //用&运算计算该微秒内产生的计数是否已经到达上限
                    if (sequence == 0)
                    {
                        //一微妙内产生的ID计数已达上限，等待下一微妙
                        timestamp = GetNextTimestamp(this.lastTimestamp);
                    }
                }
                else
                {
                    //不同微秒生成ID
                    sequence = 0L;
                }
                if (timestamp < lastTimestamp)
                {
                    throw new Exception("时间戳比上一次生成ID时时间戳还小，故异常");
                }
                this.lastTimestamp = timestamp; //把当前时间戳保存为最后生成ID的时间戳
                long Id = (timestamp << (int)timestampLeftShift)
                    | (datacenterId << (int)datacenterIdShift)
                    | (machineId << (int)machineIdShift)
                    | sequence;
                if (lastId >= Id)
                {
                    Id = lastId + 1;
                }
                lastId = Id;
                return Id;
            }
        }

    }
}
