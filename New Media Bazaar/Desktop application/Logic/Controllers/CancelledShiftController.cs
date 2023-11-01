﻿using Logic.Classes;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public class CancelledShiftController
    {
        private ICancelledShiftController _cancelledShiftDal;
        public CancelledShiftController(ICancelledShiftController cancelledShiftController)
        {
            _cancelledShiftDal = cancelledShiftController;
        }
        public bool Add(CancelledShift cancelledShift, IShiftController shiftController)
        {
            cancelledShift.Shift.IsCancelled = true;
            shiftController.Update(cancelledShift.Shift);
            return _cancelledShiftDal.Create(cancelledShift);
        }
        public bool Delete(CancelledShift cancelledShift)
        {
            return _cancelledShiftDal.Delete(cancelledShift);
        }
        public bool Update(CancelledShift cancelledShift)
        {
            return _cancelledShiftDal.Update(cancelledShift);
        }
        public CancelledShift GetById(int id)
        {
            return _cancelledShiftDal.GetById(id);
        }
        public CancelledShift[] GetAllAssigned(Employee employee)
        {
            return _cancelledShiftDal.GetAllAssigned(employee);
        }
        public CancelledShift[] GetAll()
        {
            return _cancelledShiftDal.GetAll();
        }
        public CancelledShift[] GetAllInThePast()
        {
            return _cancelledShiftDal.GetAllInThePast();
        }
        public CancelledShift[] GetAllInTheFuture()
        {
            List<CancelledShift> cancelledShifts = new();
            foreach (var cancelledShift in GetAll())
            {
                if (cancelledShift.Shift.Date >= DateTime.Today)
                {
                    cancelledShifts.Add(cancelledShift);
                }
            }
            return cancelledShifts.ToArray();
        }
        public CancelledShift[] GetAllByStatus(bool status)
        {
            return _cancelledShiftDal.GetAllByStatus(status);
        }
        public CancelledShift[] GetAllIfNewEmpAssigned(bool assigned)
        {
            return _cancelledShiftDal.GetAllIfNewEmpAssigned(assigned);
        }
    }
}
