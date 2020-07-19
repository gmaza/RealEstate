import React, { useRef } from 'react';
import { Grid, InputAdornment } from '@material-ui/core';
import {
    OwnershipTypeIcon,
    EnergyCertificateIcon,
    PropertyConditionIcon,
    DropdownIcon,
    PriceIcon,
    FurnishingIcon,
    ImageIcon,
    LongArrowRightIcon,
} from '../../icons';
import {
    StyledSelect,
    StyledFormControl,
    StyledOutlinedInput,
} from '../../globals';
import { UploadButton, Thumbnail } from './style';
import { NavButton } from '../style';

export const Description = (props) => {
    const fieldOptions = props.formData.fieldOptions;

    const fileInput = useRef(null);

    function handleAddFile(event) {
        props.handleChange('imageFiles', [
            ...(props.formData.imageFiles || []),
            ...fileInput.current.files,
        ]);
    }

    return (
        <Grid container spacing={2}>
            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.ownershipTypeId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <OwnershipTypeIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'ownershipTypeId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Ownership Type
                        </option>
                        {fieldOptions.ownershipTypes.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.energyCertificateId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <EnergyCertificateIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'energyCertificateId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Energy Performance Certificate
                        </option>
                        {fieldOptions.energyCertificates.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.propertyConditionId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <PropertyConditionIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'propertyConditionId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Property Conditions
                        </option>
                        {fieldOptions.propertyConditions.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.FurnishingId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <FurnishingIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'FurnishingId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Furnishing and Fittings
                        </option>
                        {fieldOptions.furnishings.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledOutlinedInput
                    placeholder="Price"
                    type="number"
                    startAdornment={
                        <InputAdornment>
                            <PriceIcon />
                        </InputAdornment>
                    }
                    endAdornment={<InputAdornment>Kč</InputAdornment>}
                    value={props.formData.price || ''}
                    onChange={(event) =>
                        props.handleChange('price', event.target.value)
                    }
                />
            </Grid>

            <Grid item xs={12}>
                <UploadButton onClick={() => fileInput.current.click()}>
                    <ImageIcon />
                    <span>Upload Images</span>
                </UploadButton>

                <input
                    type="file"
                    ref={fileInput}
                    multiple
                    onChange={handleAddFile}
                    style={{ display: 'none' }}
                />
            </Grid>
            <Grid item xs={12} container spacing={2}>
                {props.formData.imageFiles &&
                    props.formData.imageFiles.map((image) => (
                        <Grid
                            key={`${image.name}_${new Date().getTime()}`}
                            item
                            xs={4}
                            sm={3}
                            md={2}
                        >
                            <Thumbnail
                                style={{
                                    backgroundImage: `url(${URL.createObjectURL(
                                        image
                                    )})`,
                                }}
                            />
                        </Grid>
                    ))}
            </Grid>

            <Grid item container spacing={2}>
                <Grid item xs={6}>
                    <NavButton
                        variant="previous"
                        onClick={() => props.setStep(1)}
                    >
                        Previous Page
                    </NavButton>
                </Grid>
                <Grid item xs={6}>
                    <NavButton variant="next" onClick={() => props.setStep(3)}>
                        Continue &nbsp;
                        <LongArrowRightIcon />
                    </NavButton>
                </Grid>
            </Grid>
        </Grid>
    );
};
