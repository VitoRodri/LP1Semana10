namespace PlayerManager4
{
    public class CompareByName: IComparer<Player>
    {
        public bool Order { get; }
        
        public CompareByName(bool order)
        {
            Order=order;
            
        }
        
        

    
        

    }
}