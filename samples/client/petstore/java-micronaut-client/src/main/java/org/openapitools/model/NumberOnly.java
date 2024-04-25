/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

package org.openapitools.model;

import java.util.Objects;
import java.util.Arrays;
import java.math.BigDecimal;
import com.fasterxml.jackson.annotation.*;

import javax.validation.constraints.*;
import javax.validation.Valid;
import io.micronaut.core.annotation.*;
import javax.annotation.Generated;

/**
 * NumberOnly
 */
@JsonPropertyOrder({
  NumberOnly.JSON_PROPERTY_JUST_NUMBER
})
@JsonTypeName("NumberOnly")
@Generated(value="org.openapitools.codegen.languages.JavaMicronautClientCodegen", comments = "Generator version: 7.6.0-SNAPSHOT")
@Introspected
public class NumberOnly {
    public static final String JSON_PROPERTY_JUST_NUMBER = "JustNumber";
    private BigDecimal justNumber;

    public NumberOnly() {
    }
    public NumberOnly justNumber(BigDecimal justNumber) {
        this.justNumber = justNumber;
        return this;
    }

    /**
     * Get justNumber
     * @return justNumber
     **/
    @Nullable
    @JsonProperty(JSON_PROPERTY_JUST_NUMBER)
    @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
    public BigDecimal getJustNumber() {
        return justNumber;
    }

    @JsonProperty(JSON_PROPERTY_JUST_NUMBER)
    @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
    public void setJustNumber(BigDecimal justNumber) {
        this.justNumber = justNumber;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) {
            return true;
        }
        if (o == null || getClass() != o.getClass()) {
            return false;
        }
        NumberOnly numberOnly = (NumberOnly) o;
        return Objects.equals(this.justNumber, numberOnly.justNumber);
    }

    @Override
    public int hashCode() {
        return Objects.hash(justNumber);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("class NumberOnly {\n");
        sb.append("    justNumber: ").append(toIndentedString(justNumber)).append("\n");
        sb.append("}");
        return sb.toString();
    }

    /**
     * Convert the given object to string with each line indented by 4 spaces
     * (except the first line).
     */
    private String toIndentedString(Object o) {
        if (o == null) {
            return "null";
        }
        return o.toString().replace("\n", "\n    ");
    }

}

