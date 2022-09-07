# CryptoLibrary

[English](#English)   
[Русский](#Русский)   


## English
Class library that implements string encryption/hashing according to the selected algorithm.

### Simple algorithms

The ClassCaesar class implements the Modified Caesar algorithm   
The ClassReserve class implements the string writeback algorithm   
The ClassTransposition class implements the simple permutation algorithm   
The ClassPair class implements the pair replacement algorithm    
The ClassMatrix class implements the matrix method

### Symmetric algorithms

ClassAES - implements the AES algorithm   
ClassDES - implements the DES algorithm   
ClassRC2 - implements the RC2 algorithm   
ClassTripleDES - implements the TripleDES algorithm   
ClassRijndael - implements the Rijndael algoritm

### Asymmetric algorithms

ClassRSA - implements the RSA algorithm

### Hash Algorithms

ClassSHA256 - implements a 256-bit version of the SHA algorithm   
ClassSHA512 - implements a 512-bit version of the SHA algorithm   

### Additional functions    

ClassSalt - implements functions for adding salt to a string    


## Русский
Библиотека классов реализующих шифрование/хеширование строки по выбранному алгоритму

### Простые алгоритмы

Класс ClassCaesar реализует Модифицированный алгоритм Цезаря  
Класс ClassReserve реализует алгоритм обратной записи строки  
Класс ClassTransposition реализует алгоритм простой перестановки  
Класс ClassPair реализует алгоритм парной замены
Класс ClassMatrix реализует матричный метод    

### Симетричные алгоритмы  

ClassAES - реализует алгоритм AES  
ClassDES - реализует алгоритм DES  
ClassRC2 - реализует алгоритм RC2  
ClassTripleDES  - реализует алгоритм TripleDES  
ClassRijndael - реализует алгоритм Rijndael

### Ассиметричные алгоритмы

ClassRSA - реализует алгоритм RSA

### Алгоритмы Хеширования 

ClassSHA256 - реализует 256-битную версию алгоритма SHA   
ClassSHA512 - реализует 512-битную версию алгоритма SHA   

### Дополнительные функции    

ClassSalt - реализует функции добавления соли в строку