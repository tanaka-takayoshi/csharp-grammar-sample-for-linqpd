<Query Kind="Program" />

void Main()
{
	//bool型
	var flg1 = true;
	var flg2 = false;
	
	//int, uint, long, ulong のうち表現できる最初の型。この場合はint型
	var int1 = 1;
	//uまたはUサフィックスを付けた場合はuintもしくはulongのうち表現できる最初の型。この場合はuint型
	var int2 = 1U;
	//lまたはLサフィックスを付けた場合はlongもしくはulongのうち表現できる最初の型。この場合はuint型
	var int3 = 1L;
	//ulもしくはULサフィックスを付けた場合はulong型
	var int4 = 1UL;
	
	//単精度浮動小数点
	var number1 = 1f;
	//指数表記
	var number2 = 1.2e-3f;
	//倍精度浮動小数点
	var number3 = 1d;
	//指数表記
	var number4 = 1.2e-3d;
	//高精度小数(decimal型)
	var number5 = 0.1m;
	
	var char1 = '1';
	var char2 = '\'';
	var char3 = '\xFFFF';
	char2.Dump();
}
