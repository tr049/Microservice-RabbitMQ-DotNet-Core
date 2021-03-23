namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand: TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Amount = ammount;
        }
    }
}
