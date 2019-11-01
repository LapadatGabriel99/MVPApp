using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using ServiceLayer.Core.Services.DepartmentServices;
using RepositoryLayer.Core;
using RepositoryLayer.Core.Repository.DepartmentRepository;
using System.Diagnostics;
using ServiceLayer.Core.CommonServices;
using ServiceLayer.Persistence.CommonServices;

namespace ServiceLayer.Persistence.Services.DepartmentServices
{
    public class DepartmentCrudOperations : IDepartmentCrudOperations
    {
        private IUnitOfWork _unitOfWork;

        private IExceptionMessageStringService _exceptionMessageStringService;

        public DepartmentCrudOperations(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DepartmentCrudOperations(IUnitOfWork unitOfWork ,IExceptionMessageStringService exceptionMessageStringService)
            :this(unitOfWork)
        {
            _exceptionMessageStringService = exceptionMessageStringService;
        }

        public IDepartmentRepository GetDepartmentModel
        {
            get { return _unitOfWork.Departments; }
        } 
        
        public IDataTransaction GetDataTransaction
        {
            get { return _unitOfWork.Transaction; }
        }

        public void Add(DepartmentModel model)
        {
            try
            {
                using (_unitOfWork)
                {
                    GetDepartmentModel.Add(model);
                }
            }
            catch (Exception ex)
            {
                GetDataTransaction.RollBack();

                Debug.WriteLine(_exceptionMessageStringService.CreateExceptionMessage(ex));

                throw ex;
            }
            finally
            {
                this.Complete();
            }
        }

        public void Add(IEnumerable<DepartmentModel> rangeOfModels)
        {
            try
            {
                using(_unitOfWork)
                {
                    GetDepartmentModel.AddRange(rangeOfModels);
                }
            }
            catch (Exception ex)
            {
                GetDataTransaction.RollBack();

                Debug.WriteLine(_exceptionMessageStringService.CreateExceptionMessage(ex));

                throw ex;
            }
            finally
            {
                this.Complete();
            }
        }

        public void Complete()
        {
            _unitOfWork.Complete();
            GetDataTransaction.Commit();
        }

        public DepartmentModel Get(int id)
        {
            return GetDepartmentModel.GetById(id);
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            return GetDepartmentModel.GetAll();
        }

        public void Remove(DepartmentModel model)
        {
            try
            {
                using(_unitOfWork)
                {
                    GetDepartmentModel.Remove(model);
                }
            }
            catch (Exception ex)
            {
                GetDataTransaction.RollBack();

                Debug.WriteLine(_exceptionMessageStringService.CreateExceptionMessage(ex));

                throw ex;
            } 
            finally
            {
                this.Complete();
            }
        }

        public void Remove(IEnumerable<DepartmentModel> rangeOfModels)
        {
            try
            {
                using(_unitOfWork)
                {
                    GetDepartmentModel.RemoveRange(rangeOfModels);
                }
            }
            catch(Exception ex)
            {
                GetDataTransaction.RollBack();

                Debug.WriteLine(_exceptionMessageStringService.CreateExceptionMessage(ex));
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }        
    }
}
