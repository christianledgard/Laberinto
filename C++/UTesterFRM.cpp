//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "UTesterFRM.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
    : TForm(Owner)
{

}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnArribaClick(TObject *Sender)
{
    ClientSocket1->Host = edtHost->Text;
    ClientSocket1->Open();
    btnAbajo->Enabled = false;
    btnArriba->Enabled = false;
    btnIzquierda->Enabled = false;
    btnDerecha->Enabled = false;
    Comando = cbRaton->Text + IntToStr( ((TComponent*)Sender)->Tag );
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ClientSocket1Write(TObject *Sender,
      TCustomWinSocket *Socket)
{
   Socket->SendText(Comando + "\r\n");
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ClientSocket1Read(TObject *Sender,
      TCustomWinSocket *Socket)
{
    ListBox1->Items->Add(Socket->ReceiveText());
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ClientSocket1Disconnect(TObject *Sender,
      TCustomWinSocket *Socket)
{
    btnAbajo->Enabled = true;
    btnArriba->Enabled = true;
    btnIzquierda->Enabled = true;
    btnDerecha->Enabled = true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ClientSocket1Error(TObject *Sender,
      TCustomWinSocket *Socket, TErrorEvent ErrorEvent, int &ErrorCode)
{
    ShowMessage("No se pudo conectar");
    btnAbajo->Enabled = true;
    btnArriba->Enabled = true;
    btnIzquierda->Enabled = true;
    btnDerecha->Enabled = true;
    ErrorCode = 0;
}
//---------------------------------------------------------------------------
