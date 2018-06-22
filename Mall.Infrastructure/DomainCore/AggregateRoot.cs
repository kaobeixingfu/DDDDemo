﻿namespace Mall.Infrastructure.DomainCore
{
    /// <summary>
    /// 表示继承该类的是一个聚合根
    /// </summary>
    public abstract class AggregateRoot : Entity, IAloneStorable
    {
        //测试Jenkins是否会自动构建
    }
}
