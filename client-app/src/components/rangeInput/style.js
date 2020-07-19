import styled from 'styled-components';
import { Slider } from '@material-ui/core';

export const Container = styled.div`
    width: 100%;
`;

export const SliderContainer = styled.div`
    padding: 30px;
`;

export const StyledSlider = styled(Slider)`
    .MuiSlider-root {
        color: #3a8589;
        height: 3px;
        padding: 13px 0;
    }

    .MuiSlider-thumb {
        height: 27px;
        width: 27px;
        background-color: #fff;
        border: 1px solid currentColor;
        margin-top: -12px;
        margin-left: -13px;
        box-shadow: #ebebeb 0 2px 2px;

        &:focus,
        &:hover {
            box-shadow: #ccc 0 2px 3px 1px;
        }
        .bar {
            // display: inline-block !important;
            height: 9px;
            width: 1px;
            background-color: currentColor;
            margin-left: 1px;
            margin-right: 1px;
        }
    }
    .MuiSlider-track {
        height: 3px;
    }

    .MuiSlider-rail {
        color: #d8d8d8;
        opacity: 1;
        height: 3px;
    }
`;
