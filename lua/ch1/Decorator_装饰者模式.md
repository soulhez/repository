### 1.����

��˵˵"��"��Сѧ�ĵ����°ɡ�����Сѧ��ʱ��ѧϰ�ɼ��ǳ��Ĳ�,�༶�� 40 ���ͬѧ,�һ����϶��������� 45 ���Ժ�,������ʦ���ҵĶ�����ǡ����Ƕ�����ϡ�,�������ϰֹܵĺ��ϸ�,��֪���Ҳ��������,��������Ѽ���ϼ�,ÿ�ο�������Ҷ���սս������,�������⡱�ǿ϶��ٲ��˵�,���ٵ���ٵ��,������Լ���ѽ�����꼶��ĩ���Կ���,ѧУ������������ж�(���ж����ں����е�),��ӡ���ɼ���,Ҫ�ҳ�ǩ��,Ȼ����������꼶,���Ǹ��־�ѽ,����Ҳ���Ǽ����ӵ�ʱ��,������ʲô�������ˡ���ʱ���ҵĳɼ������� 62 ��ѧ65 ���� 98 ��Ȼ 63������Ҫ֪����Сѧ���� 90 �ֻ����Ͼ������µ���,������ѧϰ����̫����!��ô��,���Ұ�����ɼ������ϰֿ���?

����ɼ���Ҫ��ǩ��?!�ϰ־Ϳ�ʼ������,�ҵ�ƨ���Ѿ�������׼��,����Ҫ����,Ҫ���Ǹ�̫����!����,���˵���,������ǵ�ʱ����ʵ���,��û��ֱ�Ӱѳɼ��������ϰ�,�����ڽ�����֮ǰ���˵㼼������,��Ҫ�ѳɼ�����װһ��,��װ����������:

��һ��:���ϰ�˵������Ŀ����߷�,��������� 75,��ѧ�� 78,��Ȼ�� 80,Ȼ�ϰ־����ҳɼ�����߷�������,�����ʵ��,���ǲ�֪����ʲôԭ��,������ĩ���Զ����Ĳ���ô��,���ǻ����϶������� 70 ������,���� 60 ��ֻ����ϻ��ǵ�׵Ľ�ɫ;

�ڶ���:���ϰֿ��ɼ�����,���������������� 38 ��,ȫ��,���Ҳ��ʵ��,Ϊɶ��?�н���ʮ��ͬѧ��ѧ��!���������ǲ�˵�ġ���֪���ǲ��ǵ�ʱ��һ�η��ɼ���,ѧУû�п������,û��д���ܹ��ж���ͬѧ,�����ڼ����ȵ�,�����Ǳ������˸����ӡ�

��ͼ���£�

![uml](../ch1/Decorator/uml.png)

### 2.����

```lua

require "class"
 
--------ISchoolReport-------
ISchoolReport = class()
 
function ISchoolReport:Report()
 
end
 
function ISchoolReport:Sign(name)
 
end
 
--------FouthGradeSchoolReport-------
FouthGradeSchoolReport = class(ISchoolReport)
 
function FouthGradeSchoolReport:Report()
	print("----------FouthGradeSchoolReport:Report-----------")
	print("�𾴵�XXX�ҳ���")
	print(".......")
	print("����62  ��ѧ65  ����98  ��Ȼ63")
	print(".......")
	print("                �ҳ�ǩ����")
end
 
function FouthGradeSchoolReport:Sign(name)
	print("�ҳ�ǩ��Ϊ��", name)
end
 
--------ReportDecorator-------
ReportDecorator = class(ISchoolReport)
 
function ReportDecorator:ctor(psr)
	self.m_pSchoolReport = psr
end
 
function ReportDecorator:IReport()
	print("----------ReportDecorator:IReport-----------")
	self.m_pSchoolReport:Report()
end
 
function ReportDecorator:Sign(name)
	self.m_pSchoolReport:Sign(name)
end
 
--------HighScoreDecorator-------
HighScoreDecorator = class(ReportDecorator)
 
function HighScoreDecorator:Report()
	print("----------HighScoreDecorator:Report-----------")
	self:ReportHighScore()
	self:IReport()
end
 
function HighScoreDecorator:ReportHighScore()
	print("��ο������������75�� ��ѧ��78�� ��Ȼ��80")
end
 
--------SortDecorator-------
SortDecorator = class(ReportDecorator)
 
function SortDecorator:ReportSort()
	print("����������38��...")
end
 
function SortDecorator:Report()
	print("----------SortDecorator:Report-----------")
	self:IReport()
	self:ReportSort()
end
 
--------test-------
function DoIt()
	local psr = FouthGradeSchoolReport.new()
	psr:Report()
	psr:Sign("����")
end
 
function DoNew()
	print("----------�ֲ��ֽ���װ��----------")
	local psr = FouthGradeSchoolReport.new()   -- ԭװ�ɼ���
	local pssr = SortDecorator.new(psr) 		-- �ּ��˳ɼ�������˵��
	local phsr = HighScoreDecorator.new(pssr)  -- ������߷�˵���ĳɼ���
 
	phsr:Report()
	phsr:Sign("����")
end
 
--- main ---
function main()
	--DoIt()
	DoNew()
end
 
main()

```

���н����

![uml](../ch1/Decorator/debug1.png)