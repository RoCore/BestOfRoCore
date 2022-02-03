using TestApi.Dto.Data;

namespace TestApi.Dto
{
    public class SearchFilterResponse : List<EntityDto>
    {
        public SearchFilterResponse(IEnumerable<EntityDto> entities)
        {
            AddRange(entities);
        }
    }
}
