object Form1: TForm1
  Left = 192
  Top = 114
  Width = 582
  Height = 370
  Caption = 'Prueba de Laberinto'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  DesignSize = (
    574
    336)
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 48
    Top = 16
    Width = 25
    Height = 13
    Caption = 'Host:'
  end
  object Label2: TLabel
    Left = 40
    Top = 40
    Width = 32
    Height = 13
    Caption = 'Raton:'
  end
  object edtHost: TEdit
    Left = 80
    Top = 13
    Width = 121
    Height = 21
    TabOrder = 0
    Text = '127.0.0.1'
  end
  object cbRaton: TComboBox
    Left = 80
    Top = 40
    Width = 121
    Height = 22
    Style = csOwnerDrawFixed
    ItemHeight = 16
    ItemIndex = 0
    TabOrder = 1
    Text = '00'
    Items.Strings = (
      '00'
      '01'
      '02'
      '03'
      '04'
      '05'
      '06'
      '07'
      '08'
      '09'
      '10'
      '11'
      '12'
      '13'
      '14'
      '15')
  end
  object btnArriba: TButton
    Tag = 8
    Left = 80
    Top = 88
    Width = 75
    Height = 25
    Caption = 'Arriba'
    TabOrder = 2
    OnClick = btnArribaClick
  end
  object btnDerecha: TButton
    Tag = 6
    Left = 120
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Derecha'
    TabOrder = 3
    OnClick = btnArribaClick
  end
  object btnIzquierda: TButton
    Tag = 4
    Left = 40
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Izquierda'
    TabOrder = 4
    OnClick = btnArribaClick
  end
  object btnAbajo: TButton
    Tag = 2
    Left = 80
    Top = 152
    Width = 75
    Height = 25
    Caption = 'Abajo'
    TabOrder = 5
    OnClick = btnArribaClick
  end
  object ListBox1: TListBox
    Left = 216
    Top = 8
    Width = 345
    Height = 313
    Anchors = [akLeft, akTop, akRight, akBottom]
    ItemHeight = 13
    TabOrder = 6
  end
  object ClientSocket1: TClientSocket
    Active = False
    ClientType = ctNonBlocking
    Port = 3000
    OnDisconnect = ClientSocket1Disconnect
    OnRead = ClientSocket1Read
    OnWrite = ClientSocket1Write
    OnError = ClientSocket1Error
    Left = 32
    Top = 176
  end
end
