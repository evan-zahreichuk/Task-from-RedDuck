ctx.prototype.__updateStyles = function (source) {
    Object.keys(STYLES).forEach(key => {
        this[key] = source[key] ?? STYLES[key].canvas;
    });
};

ctx.prototype.__applyStyleState = function (styleState) {
    this.__updateStyles(styleState);
};

ctx.prototype.__setDefaultStyles = function () {
    this.__updateStyles(STYLES);
};

ctx.prototype.__getStyleState = function () {
    return Object.keys(STYLES).reduce((styleState, key) => {
        styleState[key] = this[key];
        return styleState;
    }, {});
};
