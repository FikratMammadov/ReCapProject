using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImages>> GetAll();

        IDataResult<CarImages> GetById(int id);

        IResult Add(CarImages carImage, IFormFile file);
        IResult Delete(CarImages carImage);
        IResult Update(CarImages carImage, IFormFile file);
    }
}
