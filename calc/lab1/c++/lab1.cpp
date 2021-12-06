//---------------------------------------------------------------------------

#include <vcl.h>
#include <iostream>
#include <string>
#include <math.h>
#pragma hdrstop

#include "lab1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
using namespace std;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button1->Caption;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button3->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button4->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button13Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button13->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button5Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button5->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button6Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button6->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button7Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button7->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button8Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button8->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button9Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button9->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button16Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10) {
		return;
	}
	if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button16->Caption;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button17Click(TObject *Sender)
{
	if(Label1->Caption.Length() == 10 || Label1->Caption == "") {
		return;
	}

	for(int i = 0; i < (Label1->Caption).Length(); i++){
		if(((Label1->Caption).c_str())[i] == '.'){
			return;
		}
	}
    if(Label1->Caption == "" && Label2->Caption != ""){
		Label2->Caption = "";
	}
	Label1->Caption = Label1->Caption + Button17->Caption;
}
//---------------------------------------------------------------------------
double myStrToFloat(String x)
{
   x = StringReplace(x, '.', FormatSettings.DecimalSeparator, TReplaceFlags() << rfReplaceAll);
   x = StringReplace(x, ',', FormatSettings.DecimalSeparator, TReplaceFlags() << rfReplaceAll);
   return StrToFloat(x);
}

void __fastcall TForm1::Button12Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;
	if (anStrLabel1 == "-" || anStrLabel1 == "+" || anStrLabel1 == "*" || anStrLabel1 == "/")
			{
				Label1->Caption += "-";
				return;
			}

	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
		Label1->Caption = Button12->Caption;
	} else{
		string action = anStrLabel1.c_str();
		cout << action[0];
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2-numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
		Label1->Caption = Button12->Caption;
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;
	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
		Label1->Caption = Button2->Caption;
	} else{
		string action = anStrLabel1.c_str();
		cout << action[0];
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2-numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		}  else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
		Label1->Caption = Button2->Caption;
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button14Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;
	if (Label1->Caption.Length() == 1)
			{
				Label1->Caption += "-";
                return;
			}

	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
		Label1->Caption = Button14->Caption;
	} else{
		string action = anStrLabel1.c_str();
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			if((Label1->Caption) == "-") {
				Label1->Caption = Label1->Caption + '-';
				return;
			} else {
				numLabel2 = myStrToFloat(anStrLabel2);
				anStrLabel1.Delete(1,1);
				numLabel1 = myStrToFloat(anStrLabel1);
				double res = numLabel2 - numLabel1;
				string result = to_string(res);
				Label2->Caption = result.c_str();
			}
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
		Label1->Caption = Button14->Caption;
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button15Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;

	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
		Label1->Caption = Button15->Caption;
	} else{
		string action = anStrLabel1.c_str();
		cout << action[0];
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2-numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
		Label1->Caption = Button15->Caption;
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button10Click(TObject *Sender)
{   UnicodeString unStr = Label1->Caption;
	AnsiString anStr = unStr;
	anStr.Delete(anStr.Length(), 1);
	Label1->Caption = anStr;
}
//---------------------------------------------------------------------------

//---------------------------------------------------------------------------

void __fastcall TForm1::Button11Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;
	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
	} else{
		string action = anStrLabel1.c_str();
		cout << action[0];
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2-numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
	}
	Label1->Caption = "";
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button18Click(TObject *Sender)
{
	double numLabel1, numLabel2;
	AnsiString anStrLabel1 = Label1->Caption;
	AnsiString anStrLabel2 = Label2->Caption;
	if((Label2->Caption).Length() == 0){
		Label2->Caption = Label1->Caption;
		Label1->Caption = Button18->Caption;
	} else{
		string action = anStrLabel1.c_str();
		cout << action[0];
		if(action[0] == '*') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2*numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '/') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2/numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '-') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2-numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '+') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			string result = to_string(numLabel2+numLabel1);
			Label2->Caption = result.c_str();
		} else if(action[0] == '^') {
			numLabel2 = myStrToFloat(anStrLabel2);
			anStrLabel1.Delete(1,1);
			numLabel1 = myStrToFloat(anStrLabel1);
			double powNum = pow(numLabel2, numLabel1);
			string result = to_string(powNum);
			Label2->Caption = result.c_str();
		}
		Label1->Caption = Button18->Caption;
	}
}
//---------------------------------------------------------------------------

