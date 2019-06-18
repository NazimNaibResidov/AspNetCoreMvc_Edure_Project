using System;


namespace Edure.Web.UI.Repostory.Abstrac.UniteOfWork
{
    public  interface IUniteOfWork:IDisposable
    {
        IProductRepstory product { get; }
        ICategoryRepostory category { get; }
    }
}
