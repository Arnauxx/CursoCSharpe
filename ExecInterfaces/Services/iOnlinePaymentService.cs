namespace ExecInterfaces.Services
{
    interface iOnlinePaymentService
    {

        double PaymentFee(double amount);
        double Interest(double amount, int months); 

    }
}
