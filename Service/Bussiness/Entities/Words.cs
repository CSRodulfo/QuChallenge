namespace QuBeyond.Backend.Bussiness.Entities
{
    public class Word
    {
        private int quantity;

        private string text;
        public string Text { get => text; set => text = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Word()
        {

        }
    }
}
