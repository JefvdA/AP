package ap.edu.spring.aop;

import javax.servlet.http.HttpServletRequest;

import org.aopalliance.intercept.Joinpoint;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.*;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Component;
import org.springframework.web.context.request.RequestContextHolder;
import org.springframework.web.context.request.ServletRequestAttributes;

@Aspect
@Component
public class InterceptableHandler {
    
    /* @Before("@annotation(ap.edu.spring.aop.Interceptable)")
    public void BeforeInterceptable(JoinPoint joinPoint){
        System.out.println("Before " + joinPoint.getSignature());
    }

    @After("@annotation(ap.edu.spring.aop.Interceptable)")
    public void AfterInterceptable(JoinPoint joinPoint){
        System.out.println("After " + joinPoint.getSignature());
    } */

    /* @Before("execution(* ap.edu.spring.jpa.PersonRepository.findAll(..))")
    public void BeforeInterceptable2(JoinPoint joinPoint){
        System.out.println("Before: " + joinPoint.getSignature());
    } */

    /* @Before("execution(* ap.edu.spring.jpa.PersonRepository.findByName(..))")
    public void BeforeInterceptable3(JoinPoint joinPoint){
        System.out.println("Before: " + joinPoint.getSignature());
        Object[] args = joinPoint.getArgs();
        for(Object arg : args) {
            System.out.println(arg);
        }
    } */

    @Around("@annotation(ap.edu.spring.aop.Interceptable) && execution(public * get*(..))")
    public ResponseEntity<String> aroundInterceptable(ProceedingJoinPoint joinPoint) throws Throwable {
        System.out.println("Around " + joinPoint.getSignature());
        HttpServletRequest request = ((ServletRequestAttributes) RequestContextHolder
            .getRequestAttributes())
            .getRequest();
        System.out.println(request.getMethod());
        System.out.println(request.getRequestURI());
        System.out.println(request.getRemoteAddr());

        String result = joinPoint.proceed().toString();
        System.out.println("RESULT: " + result);

        return new ResponseEntity<String>("Hello Intercepted Person", HttpStatus.OK);
    }
}