//---------------------------------------------------------------------------

#ifndef UTesterFRMH
#define UTesterFRMH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ScktComp.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
    TClientSocket *ClientSocket1;
    TComboBox *cbRaton;
    TButton *btnArriba;
    TButton *btnDerecha;
    TButton *btnIzquierda;
    TButton *btnAbajo;
    TListBox *ListBox1;
    TLabel *Label1;
    TLabel *Label2;
    TEdit *edtHost;
    void __fastcall btnArribaClick(TObject *Sender);
    void __fastcall ClientSocket1Write(TObject *Sender,
          TCustomWinSocket *Socket);
    void __fastcall ClientSocket1Read(TObject *Sender,
          TCustomWinSocket *Socket);
    void __fastcall ClientSocket1Disconnect(TObject *Sender,
          TCustomWinSocket *Socket);
    void __fastcall ClientSocket1Error(TObject *Sender,
          TCustomWinSocket *Socket, TErrorEvent ErrorEvent,
          int &ErrorCode);
private:	// User declarations
    AnsiString Comando;
public:		// User declarations
    __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
