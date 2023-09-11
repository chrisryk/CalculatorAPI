using Infrastructure.Interfaces;

namespace Application.Services
{
    public class EntityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOperationRepository _operationRepository;

        public EntityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _operationRepository = unitOfWork.OperationRepository;
        }
    }
}
