import React, { useState, useEffect } from 'react';
import { Container, StyledSlider, SliderContainer } from './style';
import { Popover, Typography, InputAdornment } from '@material-ui/core';
import { StyledOutlinedInput } from '../globals';
import { PriceIcon } from '../icons';

function abbreviateNumber(num, fixed) {
    if (num === null) {
        return null;
    } // terminate early
    if (num === 0) {
        return '0';
    } // terminate early
    fixed = !fixed || fixed < 0 ? 0 : fixed; // number of decimal places to show
    var b = num.toPrecision(2).split('e'), // get power
        k = b.length === 1 ? 0 : Math.floor(Math.min(b[1].slice(1), 14) / 3), // floor at decimals, ceiling at trillions
        c =
            k < 1
                ? num.toFixed(0 + fixed)
                : (num / Math.pow(10, k * 3)).toFixed(1 + fixed), // divide by power
        d = c < 0 ? c : Math.abs(c), // enforce -0 is 0
        e = d + ['', 'K', 'M', 'B', 'T'][k]; // append power
    return e;
}

export const RangeInput = (props) => {
    const [value, setValue] = useState([0, 20000000]);
    const [inputValue, setInputValue] = useState('0 - 20M');
    const [anchorEl, setAnchorEl] = React.useState(null);

    useEffect(() => {
        setInputValue(
            `${abbreviateNumber(value[0])} - ${abbreviateNumber(value[1])}`
        );
    }, [value]);

    const handleInputClick = (event) => {
        setAnchorEl(event.currentTarget);
    };

    const handlePopoverClose = () => {
        setAnchorEl(null);
    };
    const open = Boolean(anchorEl);
    const id = open ? 'simple-popover' : undefined;

    function SliderThumbComponent(props) {
        return (
            <span {...props}>
                <span className="bar" />
                <span className="bar" />
                <span className="bar" />
            </span>
        );
    }

    return (
        <Container>
            <StyledOutlinedInput
                onClick={handleInputClick}
                value={inputValue}
                startAdornment={
                    <InputAdornment>
                        <PriceIcon />
                    </InputAdornment>
                }
            />
            <Popover
                id={id}
                open={open}
                anchorEl={anchorEl}
                onClose={handlePopoverClose}
                anchorOrigin={{
                    vertical: 'bottom',
                    horizontal: 'center',
                }}
                transformOrigin={{
                    vertical: 'top',
                    horizontal: 'center',
                }}
            >
                <SliderContainer style={{ width: anchorEl?.offsetWidth }}>
                    <StyledSlider
                        min={0}
                        max={20000000}
                        ThumbComponent={SliderThumbComponent}
                        getAriaLabel={(index) =>
                            index === 0 ? 'Minimum price' : 'Maximum price'
                        }
                        valueLabelDisplay="on"
                        step={100000}
                        value={value}
                        onChange={(event, newValue) => setValue(newValue)}
                    />
                </SliderContainer>
            </Popover>
        </Container>
    );
};
