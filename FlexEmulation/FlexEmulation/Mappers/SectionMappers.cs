using FlexEmulation.Dtos.Section;
using FlexEmulation.Models;

namespace FlexEmulation.Mappers
{
    public static class SectionMappers
    {
        public static SectionDto ToSectionDto(this Section sectionModel)
        {
            return new SectionDto
            {
                Name = sectionModel.Name,
            };
        }

        public static Section ToSectionModelFromCreateDto(this CreateSectionDto sectionDto)
        {
            return new Section
            {
                Name = sectionDto.Name,
            };
        }
    }
}
