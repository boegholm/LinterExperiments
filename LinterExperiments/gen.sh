#!/bin/bash

while read -u 3 r; do 
	
	echo $r | grep -o "^.*:" | sed 's/.cs.*$//'; 
	echo $r | grep -o "override .*" | sed "s/^override //"; 
done 3< <(grep Benchmark  *.cs)
