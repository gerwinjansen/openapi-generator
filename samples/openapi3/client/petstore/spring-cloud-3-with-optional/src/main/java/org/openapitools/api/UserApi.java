/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech) (7.2.0-SNAPSHOT).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
package org.openapitools.api;

import java.time.OffsetDateTime;
import org.openapitools.model.User;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.context.request.NativeWebRequest;
import org.springframework.web.multipart.MultipartFile;

import jakarta.validation.Valid;
import jakarta.validation.constraints.*;
import java.util.List;
import java.util.Map;
import java.util.Optional;
import jakarta.annotation.Generated;

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen")
@Validated
public interface UserApi {

    /**
     * POST /user : Create user
     * This can only be done by the logged in user.
     *
     * @param user Created user object (required)
     * @return successful operation (status code 200)
     */
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user",
        consumes = "application/json"
    )
    
    ResponseEntity<Void> createUser(
         @Valid @RequestBody User user
    );


    /**
     * POST /user/createWithArray : Creates list of users with given input array
     * 
     *
     * @param user List of user object (required)
     * @return successful operation (status code 200)
     */
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user/createWithArray",
        consumes = "application/json"
    )
    
    ResponseEntity<Void> createUsersWithArrayInput(
         @Valid @RequestBody List<@Valid User> user
    );


    /**
     * POST /user/createWithList : Creates list of users with given input array
     * 
     *
     * @param user List of user object (required)
     * @return successful operation (status code 200)
     */
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user/createWithList",
        consumes = "application/json"
    )
    
    ResponseEntity<Void> createUsersWithListInput(
         @Valid @RequestBody List<@Valid User> user
    );


    /**
     * DELETE /user/{username} : Delete user
     * This can only be done by the logged in user.
     *
     * @param username The name that needs to be deleted (required)
     * @return Invalid username supplied (status code 400)
     *         or User not found (status code 404)
     */
    @RequestMapping(
        method = RequestMethod.DELETE,
        value = "/user/{username}"
    )
    
    ResponseEntity<Void> deleteUser(
         @PathVariable("username") String username
    );


    /**
     * GET /user/{username} : Get user by user name
     * 
     *
     * @param username The name that needs to be fetched. Use user1 for testing. (required)
     * @return successful operation (status code 200)
     *         or Invalid username supplied (status code 400)
     *         or User not found (status code 404)
     */
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/{username}",
        produces = "application/json"
    )
    
    ResponseEntity<User> getUserByName(
         @PathVariable("username") String username
    );


    /**
     * GET /user/login : Logs user into the system
     * 
     *
     * @param username The user name for login (required)
     * @param password The password for login in clear text (required)
     * @return successful operation (status code 200)
     *         or Invalid username/password supplied (status code 400)
     */
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/login",
        produces = "application/json"
    )
    
    ResponseEntity<String> loginUser(
        @NotNull @Pattern(regexp = "^[a-zA-Z0-9]+[a-zA-Z0-9\\.\\-_]*[a-zA-Z0-9]+$")  @Valid @RequestParam(value = "username", required = true) String username,
        @NotNull  @Valid @RequestParam(value = "password", required = true) String password
    );


    /**
     * GET /user/logout : Logs out current logged in user session
     * 
     *
     * @return successful operation (status code 200)
     */
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/logout"
    )
    
    ResponseEntity<Void> logoutUser(
        
    );


    /**
     * PUT /user/{username} : Updated user
     * This can only be done by the logged in user.
     *
     * @param username name that need to be deleted (required)
     * @param user Updated user object (required)
     * @return Invalid user supplied (status code 400)
     *         or User not found (status code 404)
     */
    @RequestMapping(
        method = RequestMethod.PUT,
        value = "/user/{username}",
        consumes = "application/json"
    )
    
    ResponseEntity<Void> updateUser(
         @PathVariable("username") String username,
         @Valid @RequestBody User user
    );

}
