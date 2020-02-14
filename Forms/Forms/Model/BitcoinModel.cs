using Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Forms.Model
{
	public class BitcoinModel: BaseViewModel
	{
		private string rates1;

		public string Currency { get; set; }
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public string rates 
		{ get => rates1;
		  set { 
				rates1 = value;
				OnPropertyChanged("rates");
			}
		}
		public string avg_6h { get; set; }
	}

	public class Bitstamp
	{
		public string high { get; set; }
		public string last { get; set; }
		public string timestamp { get; set; }
		public string bid { get; set; }
		public string vwap { get; set; }
		public string volume { get; set; }
		public string low { get; set; }
		public string ask { get; set; }
		public double open { get; set; }
	}

	public class Rates
	{
		public string last { get; set; }
	}
	public class COP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates2
	{
		public string last { get; set; }
	}

	public class BOB
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates2 rates { get; set; }
	}

	public class Rates3
	{
		public string last { get; set; }
	}

	public class USD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates3 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates4
	{
		public string last { get; set; }
	}

	public class JPY
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates4 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates5
	{
		public string last { get; set; }
	}

	public class TWD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates5 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates6
	{
		public string last { get; set; }
	}

	public class GHS
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates6 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates7
	{
		public string last { get; set; }
	}

	public class NGN
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates7 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates8
	{
		public string last { get; set; }
	}

	public class EGP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates8 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates9
	{
		public string last { get; set; }
	}

	public class IDR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates9 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates10
	{
		public string last { get; set; }
	}

	public class GEL
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates10 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates11
	{
		public string last { get; set; }
	}

	public class CRC
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates11 rates { get; set; }
	}

	public class Rates12
	{
		public string last { get; set; }
	}

	public class PEN
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates12 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates13
	{
		public string last { get; set; }
	}

	public class AED
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates13 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates14
	{
		public string last { get; set; }
	}

	public class GBP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates14 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates15
	{
		public string last { get; set; }
	}

	public class MWK
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates15 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates16
	{
		public string last { get; set; }
	}

	public class UZS
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates16 rates { get; set; }
	}

	public class Rates17
	{
		public string last { get; set; }
	}

	public class DOP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates17 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates18
	{
		public string last { get; set; }
	}

	public class LKR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates18 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates19
	{
		public string last { get; set; }
	}

	public class ETH
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates19 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates20
	{
		public string last { get; set; }
	}

	public class GTQ
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates20 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates21
	{
		public string last { get; set; }
	}

	public class CAD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates21 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates22
	{
		public string last { get; set; }
	}

	public class PKR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates22 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates23
	{
		public string last { get; set; }
	}

	public class LBP
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates23 rates { get; set; }
	}

	public class Rates24
	{
		public string last { get; set; }
	}

	public class TZS
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates24 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates25
	{
		public string last { get; set; }
	}

	public class VND
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates25 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates26
	{
		public string last { get; set; }
	}

	public class KWD
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates26 rates { get; set; }
	}

	public class Rates27
	{
		public string last { get; set; }
	}

	public class SZL
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates27 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates28
	{
		public string last { get; set; }
	}

	public class HUF
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates28 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates29
	{
		public string last { get; set; }
	}

	public class MYR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates29 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates30
	{
		public string last { get; set; }
	}

	public class AUD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates30 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates31
	{
		public string last { get; set; }
	}

	public class XRP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates31 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates32
	{
		public string last { get; set; }
	}

	public class UAH
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates32 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates33
	{
		public string last { get; set; }
	}

	public class UGX
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates33 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates34
	{
		public string last { get; set; }
	}

	public class XOF
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates34 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates35
	{
		public string last { get; set; }
	}

	public class LTC
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates35 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates36
	{
		public string last { get; set; }
	}

	public class QAR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates36 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates37
	{
		public string last { get; set; }
	}

	public class SAR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates37 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates38
	{
		public string last { get; set; }
	}

	public class DKK
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates38 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates39
	{
		public string last { get; set; }
	}

	public class HKD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates39 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates40
	{
		public string last { get; set; }
	}

	public class SEK
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates40 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates41
	{
		public string last { get; set; }
	}

	public class SGD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates41 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates42
	{
		public string last { get; set; }
	}

	public class RSD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates42 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates43
	{
		public string last { get; set; }
	}

	public class TTD
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates43 rates { get; set; }
	}

	public class Rates44
	{
		public string last { get; set; }
	}

	public class RWF
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates44 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates45
	{
		public string last { get; set; }
	}

	public class MVR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates45 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates46
	{
		public string last { get; set; }
	}

	public class VES
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates46 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates47
	{
		public string last { get; set; }
	}

	public class CHF
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates47 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates48
	{
		public string last { get; set; }
	}

	public class BWP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates48 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates49
	{
		public string last { get; set; }
	}

	public class KRW
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates49 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates50
	{
		public string last { get; set; }
	}

	public class THB
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates50 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates51
	{
		public string last { get; set; }
	}

	public class CNY
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates51 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates52
	{
		public string last { get; set; }
	}

	public class BYN
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates52 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates53
	{
		public string last { get; set; }
	}

	public class BDT
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates53 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates54
	{
		public string last { get; set; }
	}

	public class NZD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates54 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates55
	{
		public string last { get; set; }
	}

	public class CLP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates55 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates56
	{
		public string last { get; set; }
	}

	public class ZMW
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates56 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates57
	{
		public string last { get; set; }
	}

	public class XAF
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates57 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates58
	{
		public string last { get; set; }
	}

	public class EUR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates58 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates59
	{
		public string last { get; set; }
	}

	public class ILS
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates59 rates { get; set; }
	}

	public class Rates60
	{
		public string last { get; set; }
	}

	public class TRY
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates60 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates61
	{
		public string last { get; set; }
	}

	public class ARS
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates61 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates62
	{
		public string last { get; set; }
	}

	public class UYU
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates62 rates { get; set; }
	}

	public class Rates63
	{
		public string last { get; set; }
	}

	public class RON
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates63 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates64
	{
		public string last { get; set; }
	}

	public class KZT
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates64 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates65
	{
		public string last { get; set; }
	}

	public class NOK
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates65 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates66
	{
		public string last { get; set; }
	}

	public class RUB
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates66 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates67
	{
		public string last { get; set; }
	}

	public class ZAR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates67 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates68
	{
		public string last { get; set; }
	}

	public class PAB
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates68 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates69
	{
		public string last { get; set; }
	}

	public class INR
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates69 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates70
	{
		public string last { get; set; }
	}

	public class MXN
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates70 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates71
	{
		public string last { get; set; }
	}

	public class CZK
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates71 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates72
	{
		public string last { get; set; }
	}

	public class BRL
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates72 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates73
	{
		public string last { get; set; }
	}

	public class MAD
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates73 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates74
	{
		public string last { get; set; }
	}

	public class PLN
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates74 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates75
	{
		public string last { get; set; }
	}

	public class PHP
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates75 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates76
	{
		public string last { get; set; }
	}

	public class KES
	{
		public string avg_12h { get; set; }
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public string avg_1h { get; set; }
		public Rates76 rates { get; set; }
		public string avg_6h { get; set; }
	}

	public class Rates77
	{
		public string last { get; set; }
	}

	public class PYG
	{
		public string volume_btc { get; set; }
		public string avg_24h { get; set; }
		public Rates77 rates { get; set; }
	}

	public class RootObject
	{
		public COP COP { get; set; }
		public BOB BOB { get; set; }
		public USD USD { get; set; }
		public JPY JPY { get; set; }
		public TWD TWD { get; set; }
		public GHS GHS { get; set; }
		public NGN NGN { get; set; }
		public EGP EGP { get; set; }
		public IDR IDR { get; set; }
		public GEL GEL { get; set; }
		public CRC CRC { get; set; }
		public PEN PEN { get; set; }
		public AED AED { get; set; }
		public GBP GBP { get; set; }
		public MWK MWK { get; set; }
		public UZS UZS { get; set; }
		public DOP DOP { get; set; }
		public LKR LKR { get; set; }
		public ETH ETH { get; set; }
		public GTQ GTQ { get; set; }
		public CAD CAD { get; set; }
		public PKR PKR { get; set; }
		public LBP LBP { get; set; }
		public TZS TZS { get; set; }
		public VND VND { get; set; }
		public KWD KWD { get; set; }
		public SZL SZL { get; set; }
		public HUF HUF { get; set; }
		public MYR MYR { get; set; }
		public AUD AUD { get; set; }
		public XRP XRP { get; set; }
		public UAH UAH { get; set; }
		public UGX UGX { get; set; }
		public XOF XOF { get; set; }
		public LTC LTC { get; set; }
		public QAR QAR { get; set; }
		public SAR SAR { get; set; }
		public DKK DKK { get; set; }
		public HKD HKD { get; set; }
		public SEK SEK { get; set; }
		public SGD SGD { get; set; }
		public RSD RSD { get; set; }
		public TTD TTD { get; set; }
		public RWF RWF { get; set; }
		public MVR MVR { get; set; }
		public VES VES { get; set; }
		public CHF CHF { get; set; }
		public BWP BWP { get; set; }
		public KRW KRW { get; set; }
		public THB THB { get; set; }
		public CNY CNY { get; set; }
		public BYN BYN { get; set; }
		public BDT BDT { get; set; }
		public NZD NZD { get; set; }
		public CLP CLP { get; set; }
		public ZMW ZMW { get; set; }
		public XAF XAF { get; set; }
		public EUR EUR { get; set; }
		public ILS ILS { get; set; }
		public TRY TRY { get; set; }
		public ARS ARS { get; set; }
		public UYU UYU { get; set; }
		public RON RON { get; set; }
		public KZT KZT { get; set; }
		public NOK NOK { get; set; }
		public RUB RUB { get; set; }
		public ZAR ZAR { get; set; }
		public PAB PAB { get; set; }
		public INR INR { get; set; }
		public MXN MXN { get; set; }
		public CZK CZK { get; set; }
		public BRL BRL { get; set; }
		public MAD MAD { get; set; }
		public PLN PLN { get; set; }
		public PHP PHP { get; set; }
		public KES KES { get; set; }
		public PYG PYG { get; set; }
	}

}
