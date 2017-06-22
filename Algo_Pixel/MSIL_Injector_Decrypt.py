import sys, os
from PIL import Image

# Sample hash:b02638432c7139c32588c8f0406c96ebd21ec29c

def get_bytes_array(resource_path):
	img = Image.open(resource_path)
	height = img.height
	width = img.width
	img_array=img.load()
	bytes_array = []	

	for i in xrange(height):		
		for j in xrange(width):
			array = img_array[j, height-i-1]				
			bytes_array.append(array[2])
			bytes_array.append(array[1])
			bytes_array.append(array[0])
	return bytes_array

def decrypt(bytes_array):
	key = "RZ8DGTE2Cmb1qngtwdMkF5Lx9yJSjYriX0H46KfBQ"	
	bytes_array = bytes_array[4:205317]	
	part_array = bytes_array[:-1]	
	key_array = bytearray(key)
	dec_array = []
	dec_array_rev = []
	for i in xrange(len(part_array)):		
		dec_array_rev.append(part_array[i] ^ (bytes_array[-1]) ^ (key_array[i % len(key)]))

	dec_array = dec_array_rev[::-1]	
	return dec_array

def main():
	bytes_array = get_bytes_array("1.bmp")
	#with open("1.bin", "wb")as fin:
	#	fin.write(bytearray(bytes_array))
	#	fin.close()		
	dec_array = decrypt(bytes_array)
	with open("payload.exe", "wb")as f:
		f.write(bytearray(dec_array))
		f.close()
	print "Finished"	
	
main()