namespace TestApi.Mapper
{
    /// <summary>
    /// Generic definition for mapping profiles
    /// </summary>
    public interface IMapperProfile<TIn, TOut>
    {
        /// <summary>
        /// Map from in- to output
        /// </summary>
        TOut Map(TIn value);
    }
}
