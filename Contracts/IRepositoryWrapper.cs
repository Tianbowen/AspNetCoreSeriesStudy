using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    /// <summary>
    /// 当在控制器需要5个以上的IRepository时，围绕创建包装器，IOC构造注入.
    /// 使用该包装实例，我们可以调用所需的任何存储库类。
    /// </summary>
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }

        IAccountRepository Account { get; }

        void Save();
    }
}
