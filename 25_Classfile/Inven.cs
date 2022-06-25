class Inven
{
    public enum InvenDir
    {
        ID_Left,
        ID_Right,
        ID_Up,
        ID_Down,
    }

    Item[] ArrItem;
    int ItemX;
    int ItemY;
    int SelectIndex = 1;
    int Check = 0;

    // new 인벤토리를 생성하려면 int x와 y를 넣어주는 방법밖에 없게 만들었음
    public Inven(int _x, int _y)
    {
        // 방어코드는 선택이 아님
        // 방어코드 : switch문의 디폴트 등 프로그램이 터지거나 오작동하지 않게 들어오는 값들을 체크해서 문제가 없게 만드는 코드
        if (_x < 1)
        {
            _x = 1;
        }
        if (_y < 1)
        {
            _y = 1;
        }

        ItemX = _x;
        ItemY = _y;

        ArrItem = new Item[ItemX * ItemY];

    }

    /*     public void Render()
        {
            for (int i = 0; i < ItemX; i++)
            {
                for (int j = i * ItemY; j < i * ItemY + ItemY; j++)
                {
                    if (ArrItem[j] == null)
                    {
                        Console.Write(" □ ");
                    }
                    else
                    {
                        Console.Write(" ■ ");
                    }
                }
                Console.WriteLine("");
            }
        } */



    public void Render()
    {
        for (int i = 0; i < ItemX; i++) // 행
        {
            for (int j = i * ItemY; j < i * ItemY + ItemY; j++) // 열
            {
                if (j == SelectIndex - 1) // 내가 선택한 영역
                {
                    Console.Write(" ※ ");
                }
                else if (ArrItem[j] == null) // 선택하지 않았고, 아이템이 없는 영역
                {
                    Console.Write(" □ ");
                }
                else
                {
                    Console.Write(" ■ "); // 선택하지 않았고, 아이템이 있는 영역
                }

            }
            Console.WriteLine("");
        }

        if (ArrItem[SelectIndex - 1] == null) // 만약 선택한 영역에 아이템이 없었을 경우
        {
            Console.WriteLine("아이템명 : ");
            Console.WriteLine("판매가격 : ");
        }
        else // 선택한 영역에 아이템이 있었을 경우
        {
            Console.WriteLine("아이템명 : " + ArrItem[SelectIndex - 1].Name);
            Console.WriteLine("판매가격 : " + ArrItem[SelectIndex - 1].Gold);
        }
    }

    public void ItemAdd(Item _NewItem)
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] == null)
            {
                ArrItem[i] = _NewItem;
                break;
            }
            else
            {
                continue;
            }
        }
    }

    public void ItemAdd(Item _NewItem, int order)
    {
        if (order - 1 >= ArrItem.Length || order <= 0)
        {
            return;
        }
        else if (ArrItem[order - 1] != null)
        {
            return;
        }
        else
        {
            ArrItem[order - 1] = _NewItem;
            return;
        }
    }

    /*     public void ItemSelect(int _Select) // 직접 작성한 코드; 인벤토리에서 아이템을 고르는 함수
        {
            while (true)
            {
                Console.Clear();
                if (_Select > ArrItem.Length || _Select < 1) // _Select가 0 이하거나 인벤토리 전체 저장 개수보다 크면 바로 while문을 탈출하도록 함
                {
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
                }

                else // 정상적으로 숫자를 입력했을 경우
                {
                    for (int i = 0; i < ItemX; i++) // 행
                    {
                        for (int j = i * ItemY; j < i * ItemY + ItemY; j++) // 열
                        {
                            if (j == _Select - 1) // 내가 선택한 영역
                            {
                                Console.Write(" ※ ");
                            }
                            else if (ArrItem[j] == null) // 선택하지 않았고, 아이템이 없는 영역
                            {
                                Console.Write(" □ ");
                            }
                            else
                            {
                                Console.Write(" ■ "); // 선택하지 않았고, 아이템이 있는 영역
                            }
                        }
                        Console.WriteLine("");
                    }
                    if (ArrItem[_Select - 1] == null) // 만약 선택한 영역에 아이템이 없었을 경우
                    {
                        Console.WriteLine("아이템명 : ");
                        Console.WriteLine("판매가격 : ");
                    }
                    else // 선택한 영역에 아이템이 있었을 경우
                    {
                        Console.WriteLine("아이템명 : " + ArrItem[_Select - 1].Name);
                        Console.WriteLine("판매가격 : " + ArrItem[_Select - 1].Gold);
                    }
                }


                ConsoleKeyInfo input = Console.ReadKey(); // 방향키 입력을 받아서 인벤토리를 탐색할 수 있게 함
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (_Select <= ItemY) // 직접 그려보고 생각하면 쉬움, 한 가지 주의할 점은 가로가 ItemY고 세로가 ItemX라는 것
                        {
                            _Select = ItemX * ItemY - (ItemY - _Select);
                        }
                        else
                        {
                            _Select = _Select - ItemY;
                        }
                        continue;

                    case ConsoleKey.DownArrow:
                        if (_Select > ItemX * ItemY - ItemY)
                        {
                            _Select = _Select - ItemY * (ItemX - 1);
                        }
                        else
                        {
                            _Select = _Select + ItemY;
                        }
                        continue;

                    case ConsoleKey.RightArrow:
                        if (_Select == ItemX * ItemY)
                        {
                            _Select = 1;
                        }
                        else
                        {
                            _Select = _Select + 1;
                        }
                        continue;

                    case ConsoleKey.LeftArrow:
                        if (_Select == 1)
                        {
                            _Select = ItemX * ItemY;
                        }
                        else
                        {
                            _Select = _Select - 1;
                        }
                        continue;

                    case ConsoleKey.Escape:
                        return;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.ReadKey();
                        continue;

                }
            }
        } */

    public bool OverCheck(int _SelectIndex)
    {
        if (_SelectIndex < 1 || _SelectIndex > ArrItem.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SelectMoveLeft()
    {
        Check = SelectIndex - 1;
        if (OverCheck(Check) == true)
        {
            return;
        }
        else
        {
            SelectIndex -= 1;
            return;
        }
    }

    public void SelectMoveRight()
    {
        Check = SelectIndex + 1;
        if (OverCheck(Check) == true)
        {
            return;
        }
        else
        {
            SelectIndex += 1;
            return;
        }
    }

    public void SelectMoveUp()
    {
        Check = SelectIndex - ItemY;
        if (OverCheck(Check) == true)
        {
            return;
        }
        else
        {
            SelectIndex -= ItemY;
            return;
        }
    }

    public void SelectMoveDown()
    {
        Check = SelectIndex + ItemY;
        if (OverCheck(Check) == true)
        {
            return;
        }
        else
        {
            SelectIndex += ItemY;
            return;
        }
    }

    public void SelectMove(ConsoleKeyInfo _KeyInfo)
    {
        switch (_KeyInfo.Key)
        {
            case ConsoleKey.LeftArrow:
                Check = SelectIndex - 1;
                if (OverCheck(Check) == true)
                {
                    return;
                }
                else
                {
                    SelectIndex -= 1;
                    return;
                }
            case ConsoleKey.RightArrow:
                Check = SelectIndex + 1;
                if (OverCheck(Check) == true)
                {
                    return;
                }
                else
                {
                    SelectIndex += 1;
                    return;
                }
            case ConsoleKey.UpArrow:
                Check = SelectIndex - ItemY;
                if (OverCheck(Check) == true)
                {
                    return;
                }
                else
                {
                    SelectIndex -= ItemY;
                    return;
                }
            case ConsoleKey.DownArrow:
                Check = SelectIndex + ItemY;
                if (OverCheck(Check) == true)
                {
                    return;
                }
                else
                {
                    SelectIndex += ItemY;
                    return;
                }
            case ConsoleKey.Escape:
                return;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                Console.ReadKey();
                return;
        }
    }

    public void SelectItem()
    {
        while (true)
        {
            Console.Clear();
            Render();
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            Console.Clear();

            switch (KeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    SelectMoveLeft();
                    continue;

                case ConsoleKey.RightArrow:
                    SelectMoveRight();
                    continue;

                case ConsoleKey.UpArrow:
                    SelectMoveUp();
                    continue;

                case ConsoleKey.DownArrow:
                    SelectMoveDown();
                    continue;

                case ConsoleKey.D1: // 이거 esc로 바꾸면 한 개씩 짤려서 나옴
                    SelectIndex = 1;
                    return;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadKey();
                    continue;
            }
        }
    }

    public void SelectItem2()
    {
        while (true)
        {
            Console.Clear();
            Render();
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            SelectMove(KeyInfo);
        }
    }
}