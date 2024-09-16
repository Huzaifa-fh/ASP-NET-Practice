using FlexEmulation.Dtos.Branch;
using FlexEmulation.Models;

namespace FlexEmulation.Mappers
{
    public static class BranchMappers
    {
        public static BranchDto ToBranchDto(this Branch branchModel)
        {
            return new BranchDto
            {
                Name = branchModel.Name,
                Code = branchModel.Code,
            };
        }
        public static Branch ToBranchModelFromBranchDto(this CreateBranchDto branchDto)
        {
            return new Branch
            {
                Name = branchDto.Name,
                Code = branchDto.Code
            };
        }
    }
}
