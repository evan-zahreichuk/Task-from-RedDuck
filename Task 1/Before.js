ctx.prototype.__applyStyleState = function(styleState) {
    Object.keys(styleState).forEach(key => {
        this[key] = styleState[key];
    });
};

ctx.prototype.__setDefaultStyles = function() {
    Object.keys(STYLES).forEach(key => {
        this[key] = STYLES[key].canvas;
    });
};

ctx.prototype.__getStyleState = function() {
    return Object.keys(STYLES).reduce((styleState, key) => {
        styleState[key] = this[key];
        return styleState;
    }, { });
};
