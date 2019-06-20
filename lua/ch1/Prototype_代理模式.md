### 1.����

���ȴ�ʵ���������˽�ԭ��ģʽ����������������һ�ݷǳ��õĽ��壬�������Ҳ��Ҫһ�ݣ���ô��ô�죿�����ֳ�һ�ݣ���Ȼ���ǣ���Ȼ���ø�ӡ����ӡһ�����÷��㡢ֱ�ӣ�����׼ȷ��Ҳ�ߣ�������ԭ�������ƶ��������´�����˼ά��ʽ����ԭ��ģʽ�ĺ���˼�롣

Prototype PatternҲ��һ�ִ�����ģʽ������ע���Ǵ�����ͬ�����ƶ���Ĵ������⡣Ӧ��ԭ��ģʽ���ǽ���һ��ԭ�ͣ�Ȼ��ͨ����ԭ�������и��Ƶķ�����������һ����ԭ����ͬ�����Ƶ��¶��󣬻���˵��ԭ��ʵ��ָ��������������࣬����ͨ��������Щԭ�ʹ����µĶ���,���������

### 2.����

```lua

function table.deepcopy(object)
    local lookup_table = {}
 
    local function _copy(object)
        if type(object) ~= "table" then
            return object
        elseif lookup_table[object] then
            return lookup_table[object]
        end
 
        local new_table = {}
        lookup_table[object] = new_table
 
        for index, value in pairs(object) do
            new_table[_copy(index)] = _copy(value)
        end
 
        return setmetatable(new_table, getmetatable(object))
    end
 
    return _copy(object)
end
 
--------Experience-------
Experience = class()
 
function Experience:ctor()
	self.timeArea = nil
	self.company = nil
end
 
function Experience:WorkExperience(timeArea, company)
	self.timeArea = timeArea
	self.company = company
end
 
--------Resume-------
Resume = class()
 
function Resume:ctor(name)
	self.name = name
	self.sex  = nil
	self.age  = nil
	self.WorkExperience = Experience.new()
end
 
function Resume:SetPersonalInfo(sex, age)
	self.sex = sex
	self.age = age
end
 
function Resume:SetWorkExperience(timeArea, company)
	self.WorkExperience:WorkExperience(timeArea, company)
end
 
function Resume:Display()
	print(self.name, " ", self.sex, " ", self.age)
	print("��������:",self.WorkExperience.timeArea, "  ", self.WorkExperience.company)
	print("**********************")
end
 
function Resume:Clone()
	return table.deepcopy(self)
end
 
--- main ---
function main()
	A = Resume.new("Rambo")
	A:SetPersonalInfo("M", "18")
	A:SetWorkExperience("2013", "SQL")
	A:Display();
 
	B = A:Clone()
	B:SetWorkExperience("2014","C++");
	print("------------**********----------------")
	A:Display();
	B:Display()
end
 
main()

```

���н��,���£�

![debug](../ch1/Prototype/debug1.png)