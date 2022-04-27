## Caesar Cipher

Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher shifts each letter by a number of letters. 
If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet. In the case of a rotation by 3, w, x, y and z 
would map to z, a, b and c.
~~~
Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
~~~
### Example
~~~
11
middle-Outz
2
~~~
The alphabet is rotated by 2, matching the mapping above. The encrypted string is
~~~
okffng-Qwvb
~~~

**Note:** The cipher only encrypts letters; symbols, such as -, remain unencrypted.

## Function Description

Complete the caesarCipher function in the editor below.

caesarCipher has the following parameter(s):

- string s: cleartext
- int k: the alphabet rotation factor
## Returns

- string: the encrypted string

## Explanation
~~~
Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +2:    cdefghijklmnopqrstuvwxyzab

m -> o
i -> k
d -> f
d -> f
l -> n
e -> g
-    -
O -> Q
u -> w
t -> v
z -> b
~~~
