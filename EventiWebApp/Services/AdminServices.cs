using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Repositories;
using EventiWebApp.Models;


namespace EventiWebApp.Services
{
    public class AdminServices
    {
        public AdminRepository _adminRepository;

        public AdminServices(AdminRepository adminRepostiory)
        {
            _adminRepository = adminRepostiory;
        }
        public IEnumerable<Eventi> GetAllEventi()
        {
            return _adminRepository.GetAllEventi();
        }
        public void Delete(int id)
        {
            _adminRepository.Delete(id);
        }
        public async Task<Eventi> GetAsync(int id)
        {
            return await _adminRepository.GetAsync(id);
        }

        public IEnumerable<Mjesta> GetAllMjesta()
        {
            return _adminRepository.GetAllMjesta();
        }
        public void Save(Mjesta mjesto)
        {
            _adminRepository.Save(mjesto);
        }
        public void Edit(Mjesta mjesto)
        {
            _adminRepository.Edit(mjesto);
        }
        public async Task<Mjesta> GetAsyncMjesto(int id)
        {
            return await _adminRepository.GetAsyncMjesto(id);
        }
        public void DeleteMjesta(int id)
        {
            _adminRepository.DeleteMjesto(id);
        }

        public IEnumerable<VrsteEventa> GetAllVrste()
        {
            return _adminRepository.GetAllVrste();
        }
        public void Save(VrsteEventa vrsta)
        {
            _adminRepository.Save(vrsta);
        }
        
        public void Edit(VrsteEventa vrsta)
        {
            _adminRepository.Edit(vrsta);
        }
        public async Task<VrsteEventa> GetAsyncVrste(int id)
        {
            return await _adminRepository.GetAsyncVrste(id);
        }
        public void DeleteVrste(int id)
        {
            _adminRepository.DeleteVrstu(id);
        }
        public IEnumerable<Korisnici> GetAllKorisnici()
        {
            return _adminRepository.GetAllKorisnici();
        }
        public void DeleteKorisnik(int id)
        {
            _adminRepository.DeleteKorisnik(id);
        }
        public void Edit(Korisnici korisnik)
        {
            _adminRepository.Edit(korisnik);
        }
        public async Task<Korisnici> GetAsyncKorisnik(int id)
        {
            return await _adminRepository.GetAsyncKorisnik(id);
        }
    }
}
