package edu.ap.spring.controller;

import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.util.Set;

import javax.servlet.http.HttpServletResponse;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import edu.ap.spring.redis.RedisService;

@Controller
public class UserController {

	@Autowired
	private RedisService service;

	@GetMapping("/")
	private ResponseEntity<String> getIndex(){
		return new ResponseEntity<String>("You are on the index page!", HttpStatus.OK);
	}

	@GetMapping("/signup")
	private String getSignup(){
		return "signupForm";
	}

	@PostMapping("/signup")
	private String postSignup(@RequestParam("email") String email, @RequestParam("password") String password, HttpServletResponse response){

		service.incr("usercount");
		String id = service.getKey("usercount");
		String bytesToHexValue = bytesToHex(email + password);

		service.setKey("users:" + bytesToHexValue + ":" + id, email);

		return "SIGNED UP";
	}

	@GetMapping("/login")
	private String getLogin(){
		return "loginForm";
	}

	@PostMapping("/login")
	private String postLogin(@RequestParam("email") String email, @RequestParam("password") String password){
		String bytesToHexValue = bytesToHex(email + password);

		if(service.keys("users:" + bytesToHexValue + ":*").size() != 0)
			return "LOGGED IN";
		else
			return "NOT LOGGED IN";
	}

	@RequestMapping(path = "/user/{userID}")
	private String getUserEmail(@PathVariable("userID") String id){
		Set<String> keys = service.keys("users:*:" + id);
		String key = keys.iterator().next();
		String email = service.getKey(key);
		return email;
	}

	private String bytesToHex(String str) {
		String retString = "";
		try {
			MessageDigest digest = MessageDigest.getInstance("SHA-256");
			byte[] encodedhash = digest.digest((str).getBytes(StandardCharsets.UTF_8));
			StringBuffer hexString = new StringBuffer();
			for (int i = 0; i < encodedhash.length; i++) {
				String hex = Integer.toHexString(0xff & encodedhash[i]);
				if (hex.length() == 1)
					hexString.append('0');
				hexString.append(hex);
			}
			retString = hexString.toString();
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}

		return retString;
	}
}
