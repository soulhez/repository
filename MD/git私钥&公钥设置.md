# Git SSH��Կ�����봴��
### ����
1. �ҵ�**Git Base**���򿪣����У�
```
cd ~/.ssh
```
���������ssh��Կ������������ļ���
* id_rsa
* id_rsa.pub
* known_hosts
2. �����������Կ����ɾ�������У�
```
rm -rf ~/.ssh/*
```
3. �����µ�˽Կ�����У�
```
ssh-keygen -t rsa -b 4096 -C "˽Կ��Ӧ����"
```
4. �س�����,��ȡ��Կ�����У�
```
cat ~/.ssh/id_rsa.pub
```
5. ��GitHub->���ͷ��->setting->SSH adn GPG keys->New SSh key������title���ѸղŸ��Ƶ��Ƕ�ճ����key�б���
6. �������У�
```
ssh -T git@github.com
```
7. ����yes��Ȼ������㿴�� Permission denied (publickey). ��˵����ʧ���ˣ���ص��� 1 ���������ǵģ��ص��� 1��������
����㿴�� Hi FrankFang! You��ve successfully authenticated, but GitHub does not provide shell access.
�Ǿ�˵����ɹ���

### TortoiseGit����ͬһ��˽Կ
8. �кܶ෽�����磺
* ��һ��TortoiseGit�ṩ��������ܣ��Ҽ�����TortosseGit��setting����network�е�ssh-client��ΪgitĿ¼�µ�ssh.exe��
* ��������TortoiseGit/binĿ¼������**puttygen.exe**��ѡ��load�����룩˽Կ����ת�����ɡ�