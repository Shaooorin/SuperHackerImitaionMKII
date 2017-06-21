using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public static class StringUtils{
	
	private const string PASSWORD_CHARS = 
		"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	public static string GeneratePassword( int length ){
		
		var sb  = new System.Text.StringBuilder( length );
		var r   = new System.Random();

		for ( int i = 0; i < length; i++ ){
			int     pos = r.Next( PASSWORD_CHARS.Length );
			char    c   = PASSWORD_CHARS[ pos ];
			sb.Append( c );
		}

		return sb.ToString();
	}
}

public static class NumberUtils{

	private const string PASSWORD_NUMS = 
		"0123456789#$%!?/=*";

	public static string GenerateNumbers( int length ){

		var sb  = new System.Text.StringBuilder( length );
		var r   = new System.Random();

		for ( int i = 0; i < length; i++ ){
			int     pos = r.Next( PASSWORD_NUMS.Length );
			char    c   = PASSWORD_NUMS[ pos ];
			sb.Append( c );
		}

		return sb.ToString();
	}
}

public static class BinaryUtils{

	private const string PASSWORD_Bin = "01";

	public static string GenerateBinarys( int length ){

		var sb  = new System.Text.StringBuilder( length );
		var r   = new System.Random();

		for ( int i = 0; i < length; i++ ){
			int     pos = r.Next( PASSWORD_Bin.Length );
			char    c   = PASSWORD_Bin[ pos ];
			sb.Append( c );
		}

		return sb.ToString();
	}
}
