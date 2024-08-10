using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class CpuDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Cpu> GetAllCPU()
        {
            return db.Cpus.AsNoTracking().ToList();
        }
        public bool AddNewCPU(Cpu cpu)
        {
            try
            {
                if (db.Cpus.Any(c => c.Idcpu == cpu.Idcpu))
                {
                    return false;
                }

                db.Cpus.Add(cpu);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool UpdateCPU(Cpu newCpu)
        {
             try
                {
                // Find the existing entity in the context
                var existingCpu = db.Cpus.Local.FirstOrDefault(c => c.Idcpu == newCpu.Idcpu);

                if (existingCpu != null)
                {
                    // Detach the existing entity if it's already being tracked
                    db.Entry(existingCpu).State = EntityState.Detached;
                }

                // Attach the updated entity and mark it as modified
                db.Cpus.Attach(newCpu);
                db.Entry(newCpu).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
                {
                    return false;
                }
        }
    }
}
