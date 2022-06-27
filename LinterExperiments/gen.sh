#!/bin/bash

while read -u 3 r; do 
	
	c=$(echo $r | grep -o "^.*:" | sed 's/.cs.*$//'); 
	v=$(echo $r | grep -o "override .*" | sed "s/^override //");
	ret=$(echo $v | grep -o ".* " | sed 's/ $//')
	rest=$(echo $v | grep -o ' .*)' | sed 's/^ //')
#	echo $v
#	echo $ret
#	echo $rest
#	echo -n 'public ';
#	echo -n $ret
#	echo -n " $c"
        echo -n '[Benchmark] public '
	echo -n "$ret" "$c"
	echo "_$rest" ' => ' new $c'()'.$rest ';'
done 3< <(grep '\[Benchmark\]'  *.cs)
