unit ULaberintoFRM;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ScktComp;

type
  TForm1 = class(TForm)
    ClientSocket1: TClientSocket;
    Label1: TLabel;
    Label2: TLabel;
    edtHost: TEdit;
    cbRaton: TComboBox;
    btnArriba: TButton;
    btnDerecha: TButton;
    btnIzquierda: TButton;
    btnAbajo: TButton;
    ListBox1: TListBox;
    procedure btnArribaClick(Sender: TObject);
    procedure ClientSocket1Write(Sender: TObject;
      Socket: TCustomWinSocket);
    procedure ClientSocket1Read(Sender: TObject; Socket: TCustomWinSocket);
    procedure ClientSocket1Disconnect(Sender: TObject;
      Socket: TCustomWinSocket);
    procedure ClientSocket1Error(Sender: TObject; Socket: TCustomWinSocket;
      ErrorEvent: TErrorEvent; var ErrorCode: Integer);
  private
    { Private declarations }
    Comando : String;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnArribaClick(Sender: TObject);
begin
  ClientSocket1.Host := edtHost.Text;
  ClientSocket1.Open;
  btnArriba.Enabled := false;
  btnAbajo.Enabled := false;
  btnDerecha.Enabled := false;
  btnIzquierda.Enabled := false;
  Comando := cbRaton.Text + IntToStr( (Sender as TComponent).Tag );
end;

procedure TForm1.ClientSocket1Write(Sender: TObject;
  Socket: TCustomWinSocket);
begin
  Socket.SendText(Comando + #13#10);
end;

procedure TForm1.ClientSocket1Read(Sender: TObject;
  Socket: TCustomWinSocket);
begin
  ListBox1.Items.Add(Socket.ReceiveText);
end;

procedure TForm1.ClientSocket1Disconnect(Sender: TObject;
  Socket: TCustomWinSocket);
begin
  btnArriba.Enabled := true;
  btnAbajo.Enabled := true;
  btnDerecha.Enabled := true;
  btnIzquierda.Enabled := true;
end;

procedure TForm1.ClientSocket1Error(Sender: TObject;
  Socket: TCustomWinSocket; ErrorEvent: TErrorEvent;
  var ErrorCode: Integer);
begin
  ShowMessage('No se pudo conectar');
  btnArriba.Enabled := true;
  btnAbajo.Enabled := true;
  btnDerecha.Enabled := true;
  btnIzquierda.Enabled := true;
  ErrorCode := 0;
end;

end.
