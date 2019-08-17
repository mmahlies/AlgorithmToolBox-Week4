function BinarySearch(a, low , high, target)
{
if	(low > high)
	return -1;
	
	let mid = Math.floor(((high - low)/2)+low);
	
	if(a[mid] == target)
		{return mid;}
	else if(a[mid] > target)
		{return BinarySearch(a, low , mid-1 , target);}
	else if(a[mid] < target)
		{return BinarySearch(a, mid+1, high , target);}

}