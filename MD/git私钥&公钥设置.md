# Git SSH密钥生成与创建
### 流程
1. 找到**Git Base**并打开，运行：
```
cd ~/.ssh
```
如果本地有ssh密钥，会存在以下文件：
* id_rsa
* id_rsa.pub
* known_hosts
2. 如果已生成密钥，可删除，运行：
```
rm -rf ~/.ssh/*
```
3. 创建新的私钥，运行：
```
ssh-keygen -t rsa -b 4096 -C "私钥对应邮箱"
```
4. 回车三次,获取公钥，运行：
```
cat ~/.ssh/id_rsa.pub
```
5. 打开GitHub->点击头像->setting->SSH adn GPG keys->New SSh key，输入title、把刚才复制的那段粘贴到key中保存
6. 测试运行：
```
ssh -T git@github.com
```
7. 输入yes，然后如果你看到 Permission denied (publickey). 就说明你失败了，请回到第 1 步重来，是的，回到第 1步重来；
如果你看到 Hi FrankFang! You’ve successfully authenticated, but GitHub does not provide shell access.
那就说明你成功了

### TortoiseGit共用同一个私钥
8. 有很多方法，如：
* 法一：TortoiseGit提供了这个功能，右键，打开TortosseGit的setting。将network中的ssh-client改为git目录下的ssh.exe。
* 法二：打开TortoiseGit/bin目录，运行**puttygen.exe**，选择load（载入）私钥进行转换即可。