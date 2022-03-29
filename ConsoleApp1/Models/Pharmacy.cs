using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Pharmacy
    {
        //private string _medicines;
        public List<Medicine> medicines;
        public int MedicineLimit { get; set; }
        public Pharmacy(int medicinelimit)
        {
            MedicineLimit = medicinelimit;
            medicines = new List<Medicine>();
        }
        public List<Medicine> AddMedicine(Medicine _medicines)
        {
            if (_medicines.Count < MedicineLimit)
            {
                medicines.FindAll(m => m.Name == _medicines.Name);
                throw new MedicineAlreadyExistsException("Bu adda medicine var");
            }
            throw new CapacityLimitException("Limit asildi");
        }
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> copyMedicine = new List<Medicine>();
            copyMedicine.AddRange(medicines);
            return copyMedicine;

        }
        public List<Medicine> FilterMedicinesByPrice(int minPrice, int maxPrice)
        {
            return medicines.FindAll(m => m.Price >= minPrice && m.Price <= maxPrice);
        }
        public Medicine GetMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Medicine medicine = medicines.Find(m => m.Id == id);
            return medicine;
        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Medicine medicine = medicines.Find(m => m.Id == id);
            if (medicine == null)
            {
                throw new NotFoundException("Bele bir medicine yoxdur");
            }
            medicine.IsDeleted = true;
        }
        public void EditMedicineEmail(int? id, string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Medicine medicine = medicines.Find(m => m.Id == id);
            if (medicines == null)
            {
                throw new NotFoundException("Bele bir medicine yoxdur");
            }
            medicine.Name = name;
        }
    }
}
