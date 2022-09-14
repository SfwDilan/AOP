using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        [ValidationAspect(typeof(ProductValidator))]  // Bu kod Product için doğrulama kodlarını çağıracak.AOP
        public IResult Add(Product product)
        {
            
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
