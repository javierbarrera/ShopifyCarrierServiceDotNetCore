public class DTORateResponseFactory
{
    public static DTORateResponse BuildDTORateResponse(IList<IRate> rates)
    {
        return new DTORateResponse
        {
            Rates = rates.Cast<DTORate>().ToList()
        };
    }
}