using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers
{
    class FileHelper : IFileHelper
    {
        public void CheckDirectoryExists(string directory)
        {
            throw new NotImplementedException();
        }

        public IResult CheckFileExists(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public IResult CheckFileTypeValid(string type)
        {
            throw new NotImplementedException();
        }

        public void CreateFile(string directory, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(string path)
        {
            throw new NotImplementedException();
        }

        public void DeleteOldFile(string directory)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, string imagePath)
        {
            throw new NotImplementedException();
        }

        public IResult Upload(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
