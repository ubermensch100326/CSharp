// See https://aka.ms/new-console-template for more information

class Inven
{
    public void InnerClassTest(InvenSlot _invenslot)
    {
        InvenSlot NewInvenSlot = new InvenSlot();
        // _invenslot.Index 오류
        NewInvenSlot.Select(this);
        _invenslot.Select(this);
    }

    private int SelectIndex = 0;
    public class InvenSlot
    {
        private int Index;
        public void Select(Inven _inven)
        {
            _inven.SelectIndex = 100;
        }

        public int Test
        {
            get
            {
                return Index;
            }
            set
            {
                Index = value;
            }
        }
    }

}
