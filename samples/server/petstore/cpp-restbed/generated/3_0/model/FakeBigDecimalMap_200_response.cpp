/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.6.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */



#include "FakeBigDecimalMap_200_response.h"

#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <stdexcept>
#include <regex>
#include <boost/lexical_cast.hpp>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include "helpers.h"

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

FakeBigDecimalMap_200_response::FakeBigDecimalMap_200_response(boost::property_tree::ptree const& pt)
{
        fromPropertyTree(pt);
}


std::string FakeBigDecimalMap_200_response::toJsonString(bool prettyJson /* = false */) const
{
	std::stringstream ss;
	write_json(ss, this->toPropertyTree(), prettyJson);
    // workaround inspired by: https://stackoverflow.com/a/56395440
    std::regex reg("\\\"([0-9]+\\.{0,1}[0-9]*)\\\"");
    std::string result = std::regex_replace(ss.str(), reg, "$1");
    return result;
}

void FakeBigDecimalMap_200_response::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	this->fromPropertyTree(pt);
}

ptree FakeBigDecimalMap_200_response::toPropertyTree() const
{
	ptree pt;
	ptree tmp_node;
	pt.put("someId", m_SomeId);
	// generate tree for SomeMap
    if (!m_SomeMap.empty()) {
        tmp_node = toPt(m_SomeMap);
        pt.add_child("someMap", tmp_node);
    }
    tmp_node.clear();
	return pt;
}

void FakeBigDecimalMap_200_response::fromPropertyTree(ptree const &pt)
{
	ptree tmp_node;
	m_SomeId = pt.get("someId", 0.0);
    if (pt.get_child_optional("someMap")) {
        m_SomeMap = fromPt<std::map<std::string, double>>(pt.get_child("someMap"));
    }
}

double FakeBigDecimalMap_200_response::getSomeId() const
{
    return m_SomeId;
}

void FakeBigDecimalMap_200_response::setSomeId(double value)
{
    m_SomeId = value;
}


std::map<std::string, double> FakeBigDecimalMap_200_response::getSomeMap() const
{
    return m_SomeMap;
}

void FakeBigDecimalMap_200_response::setSomeMap(std::map<std::string, double> value)
{
    m_SomeMap = value;
}



std::vector<FakeBigDecimalMap_200_response> createFakeBigDecimalMap_200_responseVectorFromJsonString(const std::string& json)
{
    std::stringstream sstream(json);
    boost::property_tree::ptree pt;
    boost::property_tree::json_parser::read_json(sstream,pt);

    auto vec = std::vector<FakeBigDecimalMap_200_response>();
    for (const auto& child: pt) {
        vec.emplace_back(FakeBigDecimalMap_200_response(child.second));
    }

    return vec;
}

}
}
}
}

