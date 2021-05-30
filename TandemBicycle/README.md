public class Program {

	public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) {
		Array.Sort(redShirtSpeeds);
		Array.Sort(blueShirtSpeeds);
		int runningSum = 0;
		if(fastest == false){
			for(var i = blueShirtSpeeds.Length - 1; i >= 0; i--){
				if(blueShirtSpeeds[i] > redShirtSpeeds[i]){
					runningSum += blueShirtSpeeds[i];
				}else if(blueShirtSpeeds[i] < redShirtSpeeds[i]){
					runningSum += redShirtSpeeds[i];
				}
			}
			return runningSum;
		}
		if(fastest == true){
			int j = 0;
			for(var i = blueShirtSpeeds.Length - 1; i >= 0; i--){
				if(blueShirtSpeeds[j] > redShirtSpeeds[i]){
					runningSum += blueShirtSpeeds[j];
				}else if(blueShirtSpeeds[j] < redShirtSpeeds[i]){
					runningSum += redShirtSpeeds[i];
				}
		}
			return runningSum;

	}
}
}

brute force solution that was incorrect, just demostrates what i was thinking.
