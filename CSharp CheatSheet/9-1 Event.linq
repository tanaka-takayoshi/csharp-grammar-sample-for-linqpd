<Query Kind="Program" />

void Main()
{
	//EventHandlerのインスタンスを追加する、もしくは直接追加することが可能
	//意味合いとしては同じだが、別のインスタンスとして追加される
	Changed += new EventHandler(OnChanged);
	Changed += OnChanged;
	//EventHandlerに一つも購読のハンドラが登録されていないとnullであるため、
	//null条件演算子経由でイベントを発火させている
	Changed?.Invoke(this, new EventArgs());
	//イベントの購読を解除できる
	Changed -= OnChanged;
	Changed?.Invoke(this, new EventArgs());
	
	ValueChanged += OnValueChanged;
	ValueChanged.Invoke(this, new MyEventArgs(3));
}

void OnChanged(object sender, EventArgs ea)
{
	Console.WriteLine("OnChanged");
}

void OnValueChanged(object sender, MyEventArgs ea)
{
	Console.WriteLine($"OnValueChanged {ea.Value}");
}

event EventHandler Changed;
event EventHandler<MyEventArgs> ValueChanged;

class MyEventArgs : EventArgs
{
	public int Value { get; }
	public MyEventArgs(int value)
	{
		Value = value;
	}
}

//event構文はaddとremove処理を明示的に記述できる
//省略した場合のコードは意味合い的には下記のコードと同様だが、
//実際にはスレッドセーフなコードが生成されている
private EventHandler customHandler;
event EventHandler CustomHandler
{
	add
	{
		customHandler += value;
	}
	remove
	{
		customHandler -= value;
	}
}

//自前で定義したdelegateをイベントの型として利用することもできる
public delegate void MyEventHandler();
public event MyEventHandler MyChanged;

private int counter = 0;
//C# 7.0より式形式で記述可能
public event Action E
{
	add => ++counter;
	remove => --counter;
}