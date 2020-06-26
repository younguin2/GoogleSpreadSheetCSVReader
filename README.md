# GoogleSpreadSheetCSVReader

1. 웹에 테이블 개시 후 키값과 gid 기록
     
![1](https://user-images.githubusercontent.com/22088638/85839770-58dd3d80-b7d6-11ea-9459-83f3ea43ec2e.png)

![2](https://user-images.githubusercontent.com/22088638/85839368-ce94d980-b7d5-11ea-8a72-f2cef76874b8.png)

2. 코드작성

호출

GoogleSpreadSheetCSVReader.SpreadSheetCSVReader.GetSpreadSheetData<SpecShopProduct>("2PACX-1vR0IG9cy5IiEvudoCxzg57gWuTdL6asC3Uv0X53El_S0ZoMh0LdtUQFPnecSdIq14uc6TODrqMZD38b", "1765475500", GetSpecDataShopProductCallback);

콜백


private void GetSpecDataShopProductCallback(SpecShopProduct[] data)
{

}

3.주의사항
회사 계정으로 시트연동하면 보안때문에 안됨 (개인 계정 추천)

웹에 게시후 나온 주소의 키값 이용 (웹주소창 주소x)

