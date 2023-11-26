using Logic.Classes;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public class ShiftController
    {
        private IShiftController _shiftDal;
        public ShiftController(IShiftController shiftController)
        {
            _shiftDal = shiftController;
        }
        public bool AddShift(Shift shift)
        {
            return _shiftDal.Create(shift);
        }
        public bool DeleteShift(Shift shift)
        {
            return _shiftDal.Delete(shift);
        }
        public bool Update(Shift shift)
        {
            return _shiftDal.Update(shift);
        }
        public Shift[] GetAll()
        {
            return _shiftDal.GetAll();
        }
        public Shift[] GetAllAssigned(Employee employee)
        {
            return _shiftDal.GetAllAssigned(employee);
        }
        public Shift GetById(int id)
        {
            return _shiftDal.GetById(id);
        }
        public Shift[] GetAllByDate(DateTime date)
        {
            return _shiftDal.GetAllByDate(date);
        }
        public Shift[] GetAllByDateAndDepartment(DateTime date, Department department)
        {
            List<Shift> shifts = new();
            foreach (Shift shift in GetAllByDate(date))
            {
                if (shift.Employee.Department.Id == department.Id)
                {
                    shifts.Add(shift);
                }
            }
            return shifts.ToArray();
        }

	}
}
