import React from "react";
import {} from "prop-types";
import "./back-to-top.scss";
const propTypes = {};
import "./back-to-top.scss";
const backToTop = (props) => {
  const {} = props;
  return (
    <button className="button-back-to-top js-back-to-top" type="button">
      <span className="chevron"></span>
      <span className="u-visuallyhidden">Back to top</span>
    </button>
  );
};

backToTop.propTypes = propTypes;
export default backToTop;
