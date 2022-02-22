using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Service
{
    public class PhotosService : IPhotosService
    {
        private IRepository<Photos> _photoRepository;

        public PhotosService(IRepository<Photos> PhotoRepository)
        {

            _photoRepository = PhotoRepository;
        }
        public void Add(Photos photos)
        {
            var ret = _photoRepository.Insert(photos);
            
        }

        public void Delete(int Id)
        {
            Photos photo = GetCustomerbyId(Id);
            _photoRepository.Remove(photo);
            _photoRepository.SaveChanges();
        }

        public Photos GetCustomerbyId(int Id)
        {
            return _photoRepository.Get(Id);
        }
    }
}
