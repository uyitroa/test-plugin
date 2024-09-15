namespace CircularArray
{
    public class solution
    {
        private int nExt(int cur, ref int[] nums)
        {
            cur = (cur + nums[cur]) % nums.Length;
            Console.WriteLine("Nexting stuffs");
            cur = cur < 0 ? cur + nums.Length : cur;
            return cur;
        }
        public bool CircularArrayLoop(int[] nums)
        {
            if (nums.Length == 0)
                return false;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                    continue;

                int slow = i;
                int fast = next(i, ref nums);
                while (true)
                {
                    if (slow == fast)
                    {
                        if (slow == next(slow, ref nums))
                        {
                            break;
                        }
                        return true;
                    }

                    slow = next(slow, ref nums);

                    if (nums[fast] * nums[i] <= 0)
                    {
                        break;
                    }

                    fast = next(fast, ref nums);
                    if (nums[fast] * nums[i] <= 0)
                    {
                        break;
                    }

                    fast = next(fast, ref nums);
                }

                slow = i;
                while (nums[slow] * nums[i] > 0)
                {
                    nums[slow] = 0;
                    slow = next(slow, ref nums);
                }

            }

            return false;
        }
    }
}