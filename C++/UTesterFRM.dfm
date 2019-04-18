object Form1: TForm1
  Left = 192
  Top = 122
  Width = 526
  Height = 351
  Caption = 'Prueba Laberinto'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  DesignSize = (
    510
    315)
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 64
    Top = 37
    Width = 32
    Height = 13
    Caption = 'Raton:'
  end
  object Label2: TLabel
    Left = 64
    Top = 8
    Width = 25
    Height = 13
    Caption = 'Host:'
  end
  object cbRaton: TComboBox
    Left = 104
    Top = 32
    Width = 145
    Height = 22
    Style = csOwnerDrawFixed
    ItemHeight = 16
    ItemIndex = 0
    TabOrder = 0
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
    Left = 96
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Arriba'
    TabOrder = 1
    OnClick = btnArribaClick
  end
  object btnDerecha: TButton
    Tag = 6
    Left = 144
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Derecha'
    TabOrder = 2
    OnClick = btnArribaClick
  end
  object btnIzquierda: TButton
    Tag = 4
    Left = 48
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Izquierda'
    TabOrder = 3
    OnClick = btnArribaClick
  end
  object btnAbajo: TButton
    Tag = 2
    Left = 96
    Top = 128
    Width = 75
    Height = 25
    Caption = 'Abajo'
    TabOrder = 4
    OnClick = btnArribaClick
  end
  object ListBox1: TListBox
    Left = 272
    Top = 16
    Width = 225
    Height = 281
    Anchors = [akLeft, akTop, akRight, akBottom]
    ItemHeight = 13
    TabOrder = 5
  end
  object edtHost: TEdit
    Left = 104
    Top = 8
    Width = 121
    Height = 21
    TabOrder = 6
    Text = '127.0.0.1'
  end
  object ClientSocket1: TClientSocket
    Active = False
    ClientType = ctNonBlocking
    Host = '127.0.0.1'
    Port = 3000
    OnDisconnect = ClientSocket1Disconnect
    OnRead = ClientSocket1Read
    OnWrite = ClientSocket1Write
    OnError = ClientSocket1Error
    Left = 64
    Top = 128
  end
end
