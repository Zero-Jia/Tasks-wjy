namespace ConsoleApp2
{
    internal class Program
    {
        class AlarmClock
        {
            public event EventHandler Tick;
            public event EventHandler Alarm;
            public int alarmTime { get; set; }
            public int _currentTime;
            public AlarmClock(int alarmTime)
            {
                this.alarmTime = alarmTime;
                _currentTime = 0;
            }
            public void start()
            {
                Console.WriteLine("闹钟启动！");
                while (_currentTime < alarmTime)
                {
                    Thread.Sleep(1000);
                    _currentTime++;
                    OnTick();
                    if (_currentTime == alarmTime)
                    {
                        OnAlarm();
                    }
                }
            }
            protected virtual void OnTick()
            {
                Tick?.Invoke(this, EventArgs.Empty);
            }
            protected virtual void OnAlarm()
            {
                Alarm?.Invoke(this, EventArgs.Empty);
            }
        }
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock(10);
            alarmClock.Tick += (sender, e) =>
            {
                AlarmClock clock = (AlarmClock)sender;
                Console.WriteLine("滴答...当前时间为：" + clock._currentTime);
            };
            alarmClock.Alarm += (sender, e) =>
            {
                Console.WriteLine("叮铃铃...时间到了，该起床了！！！");
            };
            alarmClock.start();
        }
    }
}
